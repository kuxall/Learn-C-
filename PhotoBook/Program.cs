using System;

public class PhotoBook
{
    private int numPages; 

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int pages)
    {
        numPages = pages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {
    }
}

public class PhotoBookTest
{
    public static void Main(string[] args)
    {
        PhotoBook defaultPhotoBook = new PhotoBook();
        Console.WriteLine("Default photo book pages: " + defaultPhotoBook.GetNumberPages());

        PhotoBook customPhotoBook = new PhotoBook(24);
        Console.WriteLine("Custom photo book pages: " + customPhotoBook.GetNumberPages());

        BigPhotoBook largePhotoBook = new BigPhotoBook();
        Console.WriteLine("Large photo book pages: " + largePhotoBook.GetNumberPages());
    }
}
