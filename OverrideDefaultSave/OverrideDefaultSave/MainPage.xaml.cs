using Syncfusion.Maui.ImageEditor;

namespace OverrideDefaultSave;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.imageEditor.ToolbarItemSelected += OnToolBarItemSelected;
	}

    private void OnToolBarItemSelected(object sender, ToolbarItemSelectedEventArgs e)
    {
        if (e.ToolbarItem != null && e.ToolbarItem.Name == "Save")
        {
            e.Cancel = true;
            imageEditor.Save(ImageFileType.Png, imageSize: new Size(200, 200));
        }
    }
}