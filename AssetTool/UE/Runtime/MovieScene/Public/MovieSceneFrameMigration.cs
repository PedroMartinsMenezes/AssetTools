namespace AssetTool
{
    [TransferableStruct("MovieSceneFrameRange")]
    public class FMovieSceneFrameRange : ITransferable
    {
        public FFrameNumberRange Value;

        [Location("bool FMovieSceneFrameRange::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
