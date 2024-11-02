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
}
