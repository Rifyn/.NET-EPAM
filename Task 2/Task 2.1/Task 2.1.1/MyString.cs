using System;
public class MyString
{
    private char[] _customString;
    public char[] CustomString
    {
        set => _customString = value;
        get => _customString;
    }
    public MyString(string input)
    {
        _customString = input.ToCharArray();    
    }
    public char this[int index]
    {
        get => CustomString[index];
        set => CustomString[index] = value;
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
