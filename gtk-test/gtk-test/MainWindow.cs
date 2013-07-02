using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	Dialog dialog;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		dialog = new Dialog ("Sample", this, Gtk.DialogFlags.DestroyWithParent);
		dialog.Modal = true;
		dialog.AddButton ("Close", ResponseType.Close);
		dialog.Response += (o, args) => Console.WriteLine(args.ResponseId);
		dialog.Run ();
		dialog.Destroy ();
	}
}
