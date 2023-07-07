using System.Collections.ObjectModel;

namespace Markers_MAUI_Maps
{
	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }
		public ViewModel()
		{
			Data = new ObservableCollection<Model>();
			Data.Add(new Model("Albania", 3195000));
			Data.Add(new Model("Argentina", 40091359));
			Data.Add(new Model("Austria", 8372930));
			Data.Add(new Model("Belgium", 10827519));
			Data.Add(new Model("Brazil", 206598985));
			Data.Add(new Model("Cambodia", 14805000));
			Data.Add(new Model("Canada", 35151728));
			Data.Add(new Model("China", 1389750000));
			Data.Add(new Model("India", 1198003000));
			Data.Add(new Model("Korea", 48456369));
		}
	}
}
