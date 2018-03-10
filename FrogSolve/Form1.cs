using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Combinatorics.Collections;

namespace FrogSolve
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the default state of the Frog Deck
            FrogDeck fd = new FrogDeck();
            fd.LoadDeck();
            DisplayDeck(fd);


        }

        // Invoke the Solving routine and display the deck when complete
        private void btn_solve_Click(object sender, EventArgs e)
        {
            FrogDeck SolvedDeck = new FrogDeck();

            SolvedDeck = SolvePuzzle();

            if (SolvedDeck == null)
            {
                MessageBox.Show("No Solution Could Be Found!");
            }
            else
            {
                DisplayDeck(SolvedDeck);

            }


        }

        //***********************************************************************
        // SolvePuzzle does most of the work. 
        // I am using the Permutation library I installed from NuGet to compute all the permutations of the numeric range 0..8
        // For each of those permutations, I rotate each card until I find a solution to the puzzle.
        // To speed things up, if the two cards never match up, I skip over the deeper computations by "continuing" out of the loop and moving to the next permutation in the list
        //***********************************************************************

        private FrogDeck SolvePuzzle()
        {
            FrogDeck master_deck = new FrogDeck();
            master_deck.LoadDeck();

            // Get the permutations of the numbers 0 .. 8
            int[] inputSet = { 0,1,2,3,4,5,6,7,8 };
            Permutations<int> all_permutations = new Permutations<int>(inputSet, GenerateOption.WithoutRepetition);

            //Loop through each permutation of the number list
            int permutation_count = 0;

            foreach (IList<int> permutation in all_permutations)
            {
                permutation_count++;

                // load the permutation into a test deck
                FrogDeck test_deck = new FrogDeck();
                for (int i=0; i <=8; i++)
                {
                    test_deck.cards[i] = master_deck.cards[permutation[i]];
                }

                // Work way down through the card list, rotating them until it is not possible for two cards to match. If we make it all the way down to 
                // a valid card8 level match, we test the deck to ensure that it is a correct solution

                for (int c0 =0; c0<=3;c0++)
                {
                    test_deck.cards[0].rotations = c0;

                    for (int c1 = 0; c1 <= 3; c1++)
                    {
                        test_deck.cards[1].RotateCard();

                        if (test_deck.Test_Left_Right(0,1) == false) continue;

                        for (int c2 = 0; c2 <= 3; c2++)
                        {
                            test_deck.cards[2].RotateCard();

                            if (test_deck.Test_Left_Right(1,2) == false) continue;

                            for (int c3 = 0; c3 <= 3; c3++)
                            {
                                test_deck.cards[3].RotateCard();

                                if (test_deck.Test_Top_Bottom(3, 0) == false) continue;

                                for (int c4 = 0; c4 <= 3; c4++)
                                {
                                    test_deck.cards[4].RotateCard();

                                    if (test_deck.Test_Top_Bottom(4, 1) == false) continue;
                                    if (test_deck.Test_Left_Right(3, 4) == false) continue;

                                    for (int c5 = 0; c5 <= 3; c5++)
                                    {
                                        test_deck.cards[5].RotateCard();

                                        if (test_deck.Test_Top_Bottom(5, 2) == false) continue;
                                        if (test_deck.Test_Left_Right(4, 5) == false) continue;

                                        for (int c6 = 0; c6 <= 3; c6++)
                                        {
                                            test_deck.cards[6].RotateCard();

                                            if (test_deck.Test_Top_Bottom(6, 3) == false) continue;

                                            for (int c7 = 0; c7 <= 3; c7++)
                                            {
                                                test_deck.cards[7].RotateCard();

                                                if (test_deck.Test_Top_Bottom(7, 4) == false) continue;
                                                if (test_deck.Test_Left_Right(6, 7) == false) continue;

                                                for (int c8 = 0; c8 <= 3; c8++)
                                                {
                                                    test_deck.cards[8].RotateCard();

                                                    if (test_deck.Test_Top_Bottom(8, 5) == false) continue;
                                                    if (test_deck.Test_Left_Right(7, 8) == false) continue;

                                                    if (test_deck.TestSolution())
                                                    {
                                                        MessageBox.Show("Solution Found!");
                                                        lbl_permutations_checked.Text = "permutations checked: " + permutation_count.ToString();
                                                        return test_deck;
                                                    }

                                                }
                                            }

                                        }

                                    }
                                }
                            }                        
                        } 
                    }

                    test_deck.cards[0].RotateCard();

                }
            }

            return null;
        }

        private void DisplayDeck(FrogDeck p_deck)
        {

            DisplayCard(uc_frog_card1, p_deck.cards[0]);
            DisplayCard(uc_frog_card2, p_deck.cards[1]);
            DisplayCard(uc_frog_card3, p_deck.cards[2]);
            DisplayCard(uc_frog_card4, p_deck.cards[3]);
            DisplayCard(uc_frog_card5, p_deck.cards[4]);
            DisplayCard(uc_frog_card6, p_deck.cards[5]);
            DisplayCard(uc_frog_card7, p_deck.cards[6]);
            DisplayCard(uc_frog_card8, p_deck.cards[7]);
            DisplayCard(uc_frog_card9, p_deck.cards[8]);
        }

        private void DisplayCard(uc_frog_card p_usercontrol, FrogCard p_frogcard)
        {
            p_usercontrol.pb_top.BackColor = p_frogcard.top.color;
            p_usercontrol.pb_left.BackColor = p_frogcard.left.color;
            p_usercontrol.pb_right.BackColor = p_frogcard.right.color;
            p_usercontrol.pb_bottom.BackColor = p_frogcard.bottom.color;

            p_usercontrol.lbl_top.Text = p_frogcard.top.body_part;
            p_usercontrol.lbl_left.Text = p_frogcard.left.body_part;
            p_usercontrol.lbl_right.Text = p_frogcard.right.body_part;
            p_usercontrol.lbl_bottom.Text = p_frogcard.bottom.body_part;

            p_usercontrol.lbl_card_nbr.Text = p_frogcard.card_nbr.ToString();
            p_usercontrol.lbl_rotations.Text = "r: " + p_frogcard.rotations.ToString();
        }
    }
}
