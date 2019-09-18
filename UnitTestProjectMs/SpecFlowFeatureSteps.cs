using NetCoreCalculator;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectMs
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        int resultat = 0;
        Calculatrice calculatrice = new Calculatrice();



        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p_Numbre)
        {

            calculatrice.PremierNumero = p_Numbre;

        }

        [Given(@"I have entered Also (.*) into the calculator")]
        public void GivenIHaveEnteredAlsoIntoTheCalculator(int p_Numbre)
        {
            calculatrice.DexiemeNumero = p_Numbre;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            resultat = calculatrice.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p_resultat)
        {
            if (p_resultat == resultat)
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été échoué");
            }
        }
        [When(@"I press delete")]
        public void WhenIPressDelete()
        {
            resultat = calculatrice.Soustraction();
        }

        [Then(@"the result of delete should be (.*) into the calculator")]
        public void ThenTheResultOfDeleteShouldBeIntoTheCalculator(int p_resultat)
        {
            if (p_resultat == resultat)
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été échoué");
            }
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            resultat = calculatrice.Multipier();
        }

        [Then(@"the result of multiply should be (.*) into the calculator")]
        public void ThenTheResultOfMultiplyShouldBeIntoTheCalculator(int p_resultat)
        {
            if (p_resultat == resultat)
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été échoué");
            }
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            resultat = calculatrice.Division();
        }

        [Then(@"the result  of divieshould be (.*) into the calculator")]
        public void ThenTheResultOfDivieshouldBeIntoTheCalculator(int p_resultat)
        {
            if (p_resultat == resultat)
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + resultat + " ,le test a été échoué");
            }
        }
    }

}
