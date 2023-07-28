using System.Text;

namespace Homework.Extension{
    public static class stringExtention{
        public static bool IsNumber(this string str){
            if(!int.TryParse(str, out int num))return false;
            else return true;
        }

        public static bool IsDate(this string str){
            if(!DateTime.TryParse(str, out DateTime date))return false;
            else return true;
        }

        public static string[] ToWords(this string str){
            string[] result = new string[7];
            int indexOfWord = 0;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i< str.Length;i++){
                if(str[i]!=' ' || str[i]!= ',' || str[i]!='.'){
                    sb.Append(str[i]);
                }
                else if(str[i]==' '){
                    string theWord = sb.ToString();
                    result[indexOfWord] = theWord;
                    indexOfWord++;
                }
            }
            return result;
        }
    }
}