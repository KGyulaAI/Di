using System;

public class Nobel
{
	int ev;
	string tipus;
	string keresztnev;
	string vezeteknev;

	public Nobel(int ev, string tipus, string keresztnev, string vezeteknev)
	{
		this.ev = ev;
		this.tipus = tipus;
		this.keresztnev = keresztnev;
		this.vezeteknev = vezeteknev;
	}

    public int Ev { get => ev; }
    public string Tipus { get => tipus; }
    public string Keresztnev { get => keresztnev; }
    public string Vezeteknev { get => vezeteknev; }
}
