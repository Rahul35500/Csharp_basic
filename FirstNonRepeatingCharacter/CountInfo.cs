namespace FirstNonRepeatingCharacter
{
    class CountInfo
    {

        public int Count,indexed;
        public CountInfo(int index_value)
        {
            indexed=index_value;
            Count=1;
        
        }
        public void updateCount()
        {
            Count++;
        }
    }
}