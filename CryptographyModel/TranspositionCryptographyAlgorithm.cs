using System;
using System.Text;
using System.Collections.Generic;

namespace CryptographyModel
{
    public class TranspositionCryptographyAlgorithm : ITranspositionAlgorithm
    {
        private string key;

        private int[] keyOffset;

        public TranspositionCryptographyAlgorithm(string key)
        {
            this.key = key;
            this.keyOffset = TranspositionKeyOffsetHelper.parseKey(key);
        }

        public string getKey()
        {
            return this.key;
        }

        public int[] getKeyOffset()
        {
            return this.keyOffset;
        }

        public string encrypt(string message)
        {
            double nbColumns = this.key.Length;
            double nbLines = Math.Ceiling(message.Length / nbColumns);

            string[,] messageInAnArray = this.fillMessageInAnArray((int) nbLines, (int) nbColumns, message);
            Dictionary<int, string> identifiedData = this.identifyArrayColumnByKeyOffset((int) nbLines, (int) nbColumns, messageInAnArray);

            StringBuilder encryptedMessage = new StringBuilder();
            for(int currentColumn = 0; currentColumn < this.key.Length; currentColumn++)
            {
                encryptedMessage.Append(identifiedData[currentColumn]);
            }

            return encryptedMessage.ToString();
        }

        private string[,] fillMessageInAnArray(int nbLines, int nbColumns, string message)
        {
            string[,] messageInAnArray = new string[nbLines, nbColumns];
            int currentCharacter = 0;
            string characterToAppend = null;

            for (int x = 0; x < nbLines; x++)
            {
                for (int y = 0; y < nbColumns; y++)
                {
                    characterToAppend = (currentCharacter < message.Length ? message[currentCharacter].ToString() : "@");
                    messageInAnArray[x, y] = characterToAppend;
                    currentCharacter++;
                }
            }

            return messageInAnArray;
        }

        private Dictionary<int, string> identifyArrayColumnByKeyOffset(int nbLines, int nbColumns, string[,] messageInAnArray)
        {
            Dictionary<int, string> identifiedData = new Dictionary<int, string>();
            StringBuilder columnText = null;

            for (int x = 0; x < nbColumns; x++)
            {
                columnText = new StringBuilder();

                for (int y = 0; y < nbLines; y++)
                {
                    columnText.Append(messageInAnArray[y, x]);
                }

                identifiedData.Add(this.keyOffset[x], columnText.ToString());
            }

            return identifiedData;
        }

        public string decrypt(string message)
        {
            double messageLength = message.Length;
            double nbColumns = this.key.Length;
            double nbLines = Math.Ceiling(messageLength / nbColumns);
            
            string[] splitMessage = this.splitMessage(message, (int) nbLines, (int) nbColumns);
            Dictionary<int, string> identifiedData = this.identifySplitMessageByKeyOffset(splitMessage);

            StringBuilder decryptedMessage = new StringBuilder();
            for (int currentLine = 0; currentLine < nbLines; currentLine++)
            {
                for (int currentColumn = 0; currentColumn < nbColumns; currentColumn++)
                {
                    decryptedMessage.Append(identifiedData[currentColumn][currentLine]);
                }
            }

            return decryptedMessage.ToString();
        }

        private string[] splitMessage(string messageToSplit, int splitMessageLength, int keyLength)
        {
            string[] splitMessage = new string[keyLength];
            int currentCharacter = 0;
            StringBuilder message = null;

            for (int currentIndex = 0; currentIndex < splitMessage.Length; currentIndex++)
            {
                message = new StringBuilder();

                for (int currentCharacterIndex = 0; currentCharacterIndex < splitMessageLength; currentCharacterIndex++)
                {
                    message.Append(messageToSplit[currentCharacter]);
                    currentCharacter++;
                }

                splitMessage[currentIndex] = message.ToString();
            }

            return splitMessage;
        }

        private Dictionary<int, string> identifySplitMessageByKeyOffset(string[] splitMessage)
        {
            Dictionary<int, string> identifiedData = new Dictionary<int, string>();

            for(int currentIndex = 0; currentIndex < this.keyOffset.Length; currentIndex++)
            {
                identifiedData.Add(this.getCorrespondingKeyOffset(currentIndex), splitMessage[currentIndex]);
            }

            return identifiedData;
        }

        private int getCorrespondingKeyOffset(int value)
        {
            for(int index = 0; index < this.keyOffset.Length; index++)
            {
                if (this.keyOffset[index] == value)
                {
                    return index;
                }
            }

            return 0;
        }
    }
}
