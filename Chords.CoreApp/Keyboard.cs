using System;
using System.Collections.Generic;

namespace Chords.CoreApp
{
    public class Keyboard
    {
        public List<KeyMapping> KeyMappings = new List<KeyMapping>
        {
            //First column
            new KeyMapping(keyName:"ESC",columnNumber:0,rowNumber:0),
            new KeyMapping(keyName:"F1",columnNumber:1,rowNumber:0),
            new KeyMapping(keyName:"F2",columnNumber:2,rowNumber:0),
            new KeyMapping(keyName:"F3",columnNumber:3,rowNumber:0),
            new KeyMapping(keyName:"F4",columnNumber:4,rowNumber:0),
            new KeyMapping(keyName:"F5",columnNumber:6,rowNumber:0),
            new KeyMapping(keyName:"F6",columnNumber:7,rowNumber:0),
            new KeyMapping(keyName:"F7",columnNumber:8,rowNumber:0),
            new KeyMapping(keyName:"F8",columnNumber:9,rowNumber:0),
            new KeyMapping(keyName:"F9",columnNumber:11,rowNumber:0),
            new KeyMapping(keyName:"F10",columnNumber:12,rowNumber:0),
            new KeyMapping(keyName:"F11",columnNumber:13,rowNumber:0),
            new KeyMapping(keyName:"F12",columnNumber:14,rowNumber:0),
            new KeyMapping(keyName:"Snapshot",columnNumber:15,rowNumber:0),
            new KeyMapping(keyName:"Scroll Lock",columnNumber:16,rowNumber:0),
            new KeyMapping(keyName:"Pause",columnNumber:17,rowNumber:0),

            //Second column
            new KeyMapping(keyName:"`",columnNumber:0,rowNumber:1),
            new KeyMapping(keyName:"1",columnNumber:1,rowNumber:1),
            new KeyMapping(keyName:"2",columnNumber:2,rowNumber:1),
            new KeyMapping(keyName:"3",columnNumber:3,rowNumber:1),
            new KeyMapping(keyName:"4",columnNumber:4,rowNumber:1),
            new KeyMapping(keyName:"5",columnNumber:5,rowNumber:1),
            new KeyMapping(keyName:"6",columnNumber:6,rowNumber:1),
            new KeyMapping(keyName:"7",columnNumber:7,rowNumber:1),
            new KeyMapping(keyName:"8",columnNumber:8,rowNumber:1),
            new KeyMapping(keyName:"9",columnNumber:9,rowNumber:1),
            new KeyMapping(keyName:"0",columnNumber:10,rowNumber:1),
            new KeyMapping(keyName:"-",columnNumber:11,rowNumber:1),
            new KeyMapping(keyName:"=",columnNumber:12,rowNumber:1),
            new KeyMapping(keyName:"Backspace",columnNumber:14,rowNumber:1),
            new KeyMapping(keyName:"Insert",columnNumber:15,rowNumber:1),
            new KeyMapping(keyName:"Home",columnNumber:16,rowNumber:1),
            new KeyMapping(keyName:"PageUp",columnNumber:17,rowNumber:1),
        };
    }

    public class KeyMapping : IEquatable<KeyMapping>
    {
        public readonly int ColumnNumber;
        public readonly int RowNumber;
        public readonly string KeyName;

        public KeyMapping(int columnNumber, int rowNumber, string keyName)
        {
            ColumnNumber = columnNumber;
            RowNumber = rowNumber;
            KeyName = keyName;
        }

        public override bool Equals(object obj)
        {
            var keyMapping = obj as KeyMapping;

            if (keyMapping == null)
            {
                return false;
            }

            return keyMapping.ColumnNumber == ColumnNumber &&
                   keyMapping.RowNumber == RowNumber &&
                   string.Equals(KeyName, keyMapping.KeyName, StringComparison.InvariantCulture);
        }

        public bool Equals(KeyMapping other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return ColumnNumber == other.ColumnNumber &&
                   RowNumber == other.RowNumber &&
                   string.Equals(KeyName, other.KeyName, StringComparison.InvariantCulture);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = ColumnNumber;
                hashCode = (hashCode * 397) ^ RowNumber;
                hashCode = (hashCode * 397) ^ StringComparer.InvariantCulture.GetHashCode(KeyName);

                return hashCode;
            }
        }

        public static bool operator ==(KeyMapping left, KeyMapping right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(KeyMapping left, KeyMapping right)
        {
            return !Equals(left, right);
        }
    }
}
