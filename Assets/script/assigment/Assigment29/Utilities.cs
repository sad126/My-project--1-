namespace assigment29{
    public static class Utilities
    {
        public static int Add(params int[] numbers){
            int sum = 0;
            foreach(int x in numbers){
                sum += x;
            }
            return sum;
        }
        public static string RepeatString(this string str, int count){
            string timp = "";
            for(int i = 0; i < count;i++){
                timp += str;
            }
            return timp;
        }
        
    }
}