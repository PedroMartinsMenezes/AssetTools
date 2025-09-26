namespace AssetTool
{
    [JsonAsset("WidgetAnimation")]
    public class UWidgetAnimation : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferibleStruct("MovieSceneTrackFieldData")]
    public class FMovieSceneTrackFieldData : ITransferible
    {
        public List<TUInt8> UnknowData;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref UnknowData, 42);
            return this;
        }
    }

    [TransferibleStruct("MovieSceneSubSectionFieldData")]
    public class FMovieSceneSubSectionFieldData : ITransferible
    {
        public List<TUInt8> UnknowData;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref UnknowData, 42);
            return this;
        }
    }
}