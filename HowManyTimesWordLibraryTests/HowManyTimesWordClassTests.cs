using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HowManyTimesWordLibrary;

namespace HowManyTimesWordLibraryTests
{
    [TestClass]
    public class HowManyTimesWordClassTests
    {
        //Возвращение пустой строки
        [TestMethod]
        public void WordCount_StringEmpty_Returned0()
        {
            //Arrange
            string text = "";
            string word = "";
            int excepted = 0;
            //Act
            int actual = HowManyTimesWordClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void WordCount_WordStringEmpty_Returned0()
        {
            //Arrange
            string text = "папая папая папая";
            string word = "";
            int excepted = 0;
            //Act
            int actual = HowManyTimesWordClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        //Возвращение количества слова "папая"
        [TestMethod]
        public void WordCount_Papaya_Returned2()
        {
            //Arrange
            string text ="Эх папая ты моя папая";
            string word ="папая";
            int excepted = 2;
            //Act
            int actual=HowManyTimesWordClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);  
        }
        //Возвращение количества слова "папая", когда слова в тексте нет
        [TestMethod]
        public void WordCount_Papaya_Returned0()
        {
            //Arrange
            string text = "Эх ты моя ";
            string word = "папая";
            int excepted = 0;
            //Act
            int actual = HowManyTimesWordClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        
    }
}
