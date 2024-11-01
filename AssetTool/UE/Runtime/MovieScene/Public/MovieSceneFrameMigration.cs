namespace AssetTool
{
    [TransferibleStruct("MovieSceneFrameRange")]
    public class FMovieSceneFrameRange : ITransferible
    {
        public FFrameNumberRange Value;

        [Location("bool FMovieSceneFrameRange::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    /*
    FMovieSceneFrameRange
		bool FMovieSceneFrameRange::Serialize(FArchive& Ar)
			TRange<FFrameNumber> Value;
				struct FFrameNumberRange
				{
					FFrameNumberRangeBound LowerBound;
					FFrameNumberRangeBound UpperBound;
				};
				struct FFrameNumberRangeBound
				{									
					TEnumAsByte<ERangeBoundTypes::Type> Type;
					FFrameNumber Value;
				};
				struct FFrameNumber
				{					
					int32 Value;
				}; 
    */
}
