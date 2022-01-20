using System;
public class MyString
{
    private char[] _customString;
    public char[] CustomString
    {
        set
        {
            if (value == null)
            {
                _customString = new char[0];
            }
            else
            {
                _customString = value;
            }
        }
        get
        {
            return _customString;
        }
    }
    public MyString(string input)
    {
        if (input != null) _customString = input.ToCharArray();
        else _customString = new char[0];
    }
    public char this[int index]
    {
        get => CustomString[index];
        set
        {
            if (index >= CustomString.Length)
            {
                CustomString[CustomString.Length - 1] = value;
            }
            else if (index < 0)
            {
                CustomString[0] = value;
            }
            else CustomString[index] = value;
        }
    }
    public bool Equals(MyString str)
    {
        if (this.CustomString.Length == str.CustomString.Length)
        {
            for (int i = 0; i < this.CustomString.Length; i++)
            {
                if (this[i] != str[i]) return false;
            }
            return true;
        }
        return false;
    }
    public static MyString operator +(MyString firstString, MyString secondString)
    {
        return new MyString(firstString.CustomString.ToString() + secondString.CustomString.ToString());
    }
    public static bool operator <(MyString firstString, MyString secondString)
    {
        return firstString.CustomString.Length < secondString.CustomString.Length;
    }
    public static bool operator >(MyString firstString, MyString secondString)
    {
        return firstString.CustomString.Length > secondString.CustomString.Length;
    }
    public bool CharSearch(char symbol)
    {
        foreach (char c in CustomString)
        {
            if (c == symbol) return true;
        }
        return false;
    }
}
