// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;

using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.GUI.Imp.Model.Specifications
{
	internal class SizeSpecification : ISpecification
	{
		private readonly long _maxSize;
		private readonly long _minSize;

		public SizeSpecification(
			long? minSize,
			long? maxSize )
		{
			Contract.Requires<ArgumentException>( ( minSize ?? 0 ) >= 0 );
			Contract.Requires<ArgumentException>( ( maxSize ?? long.MaxValue ) >= ( minSize ?? 0 ) );

			_minSize = minSize ?? 0;
			_maxSize = maxSize ?? long.MaxValue;
		}

		public bool IsSatisfiedBy( IFileInfo file )
		{
			return file.Length >= _minSize && file.Length <= _maxSize;
		}
	}
}