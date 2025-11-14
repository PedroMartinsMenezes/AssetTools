namespace AssetTool
{
    [JsonAsset("WidgetAnimation")]
    public class UWidgetAnimation : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferableStruct("MovieSceneTrackFieldData")]
    public class FMovieSceneTrackFieldData : ITransferable
    {
        public List<TUInt8> UnknowData;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref UnknowData, 42);
            return this;
        }
    }

    [TransferableStruct("MovieSceneSubSectionFieldData")]
    public class FMovieSceneSubSectionFieldData : ITransferable
    {
        public List<TUInt8> UnknowData;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref UnknowData, 42);
            return this;
        }
    }
}