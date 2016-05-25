﻿using Hover.Common.Utils;

namespace Hover.Common.Renderers.Shapes.Rect {

	/*================================================================================================*/
	public abstract class HoverMeshRectTrack : HoverMesh {
	
		public const string SizeXName = "SizeX";
		public const string SizeYName = "SizeY";
		public const string UvStartYName = "UvStartY";
		public const string UvEndYName = "UvEndY";
		public const string IsFillName = "IsFill";

		[DisableWhenControlled(RangeMin=0, RangeMax=100)]
		public float SizeX = 10;
		
		[DisableWhenControlled(RangeMin=0, RangeMax=100)]
		public float SizeY = 10;
		
		[DisableWhenControlled(RangeMin=0, RangeMax=1)]
		public float UvStartY = 0;

		[DisableWhenControlled(RangeMin=0, RangeMax=1)]
		public float UvEndY = 1;

		[DisableWhenControlled]
		public bool IsFill = false;
		
		private float vPrevSizeX;
		private float vPrevSizeY;
		private float vPrevUvStartY;
		private float vPrevUvEndY;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected override bool ShouldUpdateMesh() {
			bool shouldUpdate = (
				base.ShouldUpdateMesh() ||
				SizeX != vPrevSizeX ||
				SizeY != vPrevSizeY ||
				UvStartY != vPrevUvStartY ||
				UvEndY != vPrevUvEndY
			);

			vPrevSizeX = SizeX;
			vPrevSizeY = SizeY;
			vPrevUvStartY = UvStartY;
			vPrevUvEndY = UvEndY;

			return shouldUpdate;
		}
		
	}

}
