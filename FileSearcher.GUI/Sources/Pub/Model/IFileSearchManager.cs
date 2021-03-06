using System.Collections.Generic;

using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.GUI.Pub.Model
{
	public interface IFileSearchManager {
		IEnumerable<IFileInfo> Search(
			FileSearchSettings settings,
			ISpecification filter );

		bool ResultIsLimited { get; }
	}
}