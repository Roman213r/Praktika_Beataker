using System;
using System.Collections.ObjectModel;
using LogicApp.Models;

namespace LogicApp.ViewModels
{
	public class ExaminationsViewModel : BaseViewModel
	{
		private ObservableCollection<Group> _groups = new ObservableCollection<Group>();
		public ObservableCollection<Group> Groups
        {
			get { return _groups; }
			set { SetProperty(ref _groups, value); }
        }

		public ExaminationsViewModel()
		{
            for (int groupIndex = 0; groupIndex < Helpers.Data.GroupNames.Length; ++groupIndex)
            {
                Groups.Add(new Group
                {
                    Id = groupIndex,
                    Name = Helpers.Data.GroupNames[groupIndex],
                    DescriptionTitle = Helpers.Data.GroupDescriptionTitles[groupIndex],
                    Description = Helpers.Data.GroupDescriptions[groupIndex],
                    GroupColor = Helpers.Data.GroupColors[groupIndex],
                    Letters = Helpers.Data.Letters[groupIndex],
                });
            }
        }
	}
}

