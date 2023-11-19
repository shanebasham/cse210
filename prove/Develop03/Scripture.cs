using System;
using System.Security.Cryptography.X509Certificates;

// namespace scripture_memorizer
// {
//     public class Scripture
//     {
//         public string _reference;
//         public string _verse,
//         public List<Word> _words = new List<Word>();

//         public Scripture(Reference Reference, string text)
//         {
//             Reference = reference;
//             Verse = verse;
//             _words = verse.Split(' ');
//             _hiddenWords = new List<int>();
//         }
//         public void HideRandomWords(int numberToHide)
//         {  

//         }
//         public string GetDisplayText()
//         {
//             string text = $"text...";
//             return text;
//         } 
//         public bool IsCompletelyHidden()
//         {
//             bool text = true;
//             return text;
//         }
//     } 
// }



namespace scripture_memorizer
{
    public class Scripture
    {
        public string Reference { get; set; }
        public string Verse { get; set; }
        public string[] _words;
        public List<Word> _hiddenWords;

        public Scripture(string reference, string verse)
        {
            Reference = reference;
            Verse = verse;
            _words = verse.Split(' ');
            _hiddenWords = new List<Word>();
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            Word._isHidden();
            
            
            // for (int i = 0; i < numberToHide; i++)
            // {
            //     int randomIndex;
            //     do
            //     {
            //         randomIndex = random.Next(_words.Length);
            //     } while (_hiddenWords.Contains(randomIndex));
            //     _hiddenWords.Add(randomIndex);
            // }

            // Random rndm = new Random();
            // var result = Verse.ToArray();
            // var randomWords= Enumerable.Range(0, Verse.Length).OrderBy(x => rndm.Next()).Take(numberToHide);
            // foreach (var word in randomWords)
            // {
            //     result[word] = '*';
            // }
            // _words = result;

            // Random rnd = new Random();
            // var inputString = Verse;
            // var randomIndices = Enumerable.Range(0,inputString.Length)
            //                             .OrderBy(x=>rnd.Next())
            //                             .Take(numberToHide)
            //                             .ToList();

            // for(int i=0;i<inputString.Length;i++)
            // {
            //     _hiddenWords.Append(randomIndices.Contains(i) ? '*':inputString[i]);
            // }
            // var result = _hiddenWords.ToString();

            // Random rnd = new Random();
            // while (numberToHide > 0)
            // {
            //     int index = rnd.Next();
            //     if (!Verse[index].Hidden)
            //     {
            //         Verse[index].Hidden = true;
            //     }
            // }
        }
        public string GetDisplayText()
        {
            string text = $"Scripture";
            return text;
        } 

        public bool IsCompletelyHidden()
        {
            // bool text = true;
            // return text;
            return _hiddenWords.Count == _words.Length;
        }
    }
}



