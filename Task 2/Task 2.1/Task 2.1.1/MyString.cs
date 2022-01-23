using System;
public class MyString
{
    private char[] _customString;
    public MyString(string input)
    {
        _customString = input.ToCharArray();    
    }
    public char this[int index]
    {
        get => _customString[index];
        set => _customString[index] = value;
    }
    public bool Equals(MyString str)
    {
        if (this._customString.Length == str._customString.Length)
        {
            for (int i = 0; i < this._customString.Length; i++)
            {
                if (this[i] != str[i]) return false;
            }
            return true;
        }
        return false;
    }
    public static MyString operator +(MyString firstString, MyString secondString)
    {
        return new MyString(firstString._customString.ToString() + secondString._customString.ToString());
    }
    public static bool operator <(MyString firstString, MyString secondString)
    {
        return firstString._customString.Length < secondString._customString.Length;
    }
    public static bool operator >(MyString firstString, MyString secondString)
    {
        return firstString._customString.Length > secondString._customString.Length;
    }
    public bool CharSearch(char symbol)
    {
        foreach (char c in _customString)
        {
            if (c == symbol) return true;
        }
        return false;
    }
}
