using System.Diagnostics;

namespace IT_5_term_lab_5;

public class BigInteger
{
    internal int[] _numbers;

    internal bool _isNegative = false;
    
    

    public BigInteger(string value)
    {
        if (value[0] == '-')
        {
            value = value.Substring(1);
            _isNegative = true;
        }
        _numbers = new int[value.Length];
        for (int i = 0; i < value.Length; i++)
        {
            _numbers[value.Length - i - 1] = value[i] - '0';
        }
    }

    private BigInteger(int[] value, bool isNegative)
    {
        _numbers = value;
        _isNegative = isNegative;
    }
    
    public override string ToString()
    {
        var returnValue = _isNegative ? "-" : ""  ;
        for (int i = _numbers.Length- 1; i >= 0; i--)
        {
            returnValue += _numbers[i];
            
        }
        return returnValue;
    }
    
    public BigInteger Add(BigInteger another)
    {
        // Positive + Negative 
        if (!_isNegative && another._isNegative)
        {
            return Sub(new BigInteger(another._numbers, false));
        }
        // Negative + Positive
        if (_isNegative && !another._isNegative)
        {
            return another.Sub(new BigInteger(_numbers, false));
        }
        var memoriseDigit = 0;
        var result = new List<int>();
        var resultLength = Math.Max(_numbers.Length, another._numbers.Length);
        
        for (int i = 0; i < resultLength ; i++)
        {
            var current2 = i >= another._numbers.Length ? 0 : another._numbers[i];
            var current1 = i >= _numbers.Length ? 0 : _numbers[i];
            var currentSum = current1 + current2 + memoriseDigit;
            if (currentSum > 9)
            {
                currentSum -= 10;
                memoriseDigit = 1;
            }
            else
            {
                memoriseDigit = 0;
            }
            result.Add(currentSum);
        }

        if (memoriseDigit != 0)
        {
            result.Add(1);
        }
        return new BigInteger(result.ToArray(), _isNegative);
    }
    
    public BigInteger Sub(BigInteger another)
    {
        // Positive - Negative 
        if (!_isNegative && another._isNegative)
        {
            return Add(new BigInteger(another._numbers, false));
        }
        // Negative - Positive
        if (_isNegative && !another._isNegative)
        {
            return Add(new BigInteger(another._numbers, true));
        }
        // Negative - Negative
        if (_isNegative && another._isNegative)
        {
            return new BigInteger(another._numbers, false).Sub(new BigInteger(_numbers, false));
        }

        if (this < another)
        {
            var result1 = another.Sub(this);
            return new BigInteger(result1._numbers, true) ;
        }
        
        var memoriseDigit = 0;
        var result = new List<int>();
        var resultLength = Math.Max(_numbers.Length, another._numbers.Length);
        for (int i = 0; i < resultLength; i++)
        {
            var current2 = i >= another._numbers.Length ? 0 : another._numbers[i];
            var current1 = i >= _numbers.Length ? 0 : _numbers[i];
            
            var currentSum = current1 - current2 - memoriseDigit;
            if (currentSum < 0)
            {
                currentSum += 10;
                memoriseDigit = 1;
            }
            else
            {
                memoriseDigit = 0;
            }
            result.Add(currentSum);
        }

        while (result[result.Count - 1] == 0 && result.Count > 1)
        {
            result.RemoveAt(result.Count -1);
        }
        return new BigInteger(result.ToArray(), _isNegative);
    }
    public static BigInteger operator +(BigInteger a, BigInteger b) => a.Add(b);
    public static BigInteger operator -(BigInteger a, BigInteger b) => a.Sub(b);

    public static bool operator >(BigInteger a, BigInteger b)
    {
        if (!a._isNegative && b._isNegative)
        {
            return true;
        }
        if (a._isNegative && !b._isNegative)
        {
            return false;
        }

        if (a._numbers.Length > b._numbers.Length )
        {
            return !a._isNegative;
        }
        if (a._numbers.Length < b._numbers.Length )
        {
            return a._isNegative;
        }

        for (int i = a._numbers.Length; i >= 0; i--)
        {
            if (a._numbers[i] > b._numbers[i])
            {
                return !a._isNegative;
            }
            if (a._numbers[i] < b._numbers[i])
            {
                return a._isNegative;
            }
        }
        return false;
    }
    public static bool operator <(BigInteger a, BigInteger b)
    {
        if (!a._isNegative && b._isNegative)
        {
            return false;
        }
        if (a._isNegative && !b._isNegative)
        {
            return true;
        }

        if (a._numbers.Length < b._numbers.Length )
        {
            return !a._isNegative;
        }
        if (a._numbers.Length > b._numbers.Length )
        {
            return a._isNegative;
        }

        for (int i = a._numbers.Length - 1; i >= 0; i--)
        {
            if (a._numbers[i] < b._numbers[i])
            {
                return !a._isNegative;
            }
            if (a._numbers[i] > b._numbers[i])
            {
                return a._isNegative;
            }
        }
        return false;
    }
}
