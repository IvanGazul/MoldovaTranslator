namespace NewDesignedTranslator.Classes.TranslatorClasses.Mistakes
{
    public class PotentialMisspelledWord
    {
        public string _PMW { get; set; }
        public string _originalPMW {get; private set; }
        public int _startPosition { get; private set; }
        public int _endPosition { get; private set; }

        public PotentialMisspelledWord(string PMW, string originalPMW, int startPosition, int endPosition)
        {
            _PMW = PMW;
            _originalPMW = originalPMW;
            _startPosition = startPosition;
            _endPosition = endPosition;
        }

        //Это я судя по позиции в тексте?
        public bool CheckPosition(int position)
        {
            //Да
            if(position >= _startPosition & position <= _endPosition) 
                return true;

            //Нет
            return false;
        }
    }
}
