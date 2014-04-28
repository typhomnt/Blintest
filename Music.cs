using System;

public class Music
{

    private int Id;
    private string Nom_mp3;
    private string Nom_picture;
    private Music* next;

	public Music()
	{
        this.Id = 0;
        this.Nom_mp3 = "";
        this.Nom_picture = "";
        this.next = NULL;
	}
}
