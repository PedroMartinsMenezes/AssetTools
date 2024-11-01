namespace AssetTool
{
    public class FMovieSceneTangentData : ITransferible
    {
        public float ArriveTangent;
        public float LeaveTangent;
        public float ArriveTangentWeight;
        public float LeaveTangentWeight;
        public byte TangentWeightMode;
        public byte[] UnserializedPaddingBytes = [0, 0, 0];

        [Location("bool FMovieSceneTangentData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.SerializeFloatChannel)
            {
                return this;
            }

            if (!Supports.SerializeFloatChannelCompletely)
            {
                transfer.Move(ref ArriveTangent);
                transfer.Move(ref LeaveTangent);
                transfer.Move(ref TangentWeightMode);
                transfer.Move(ref ArriveTangentWeight);
                transfer.Move(ref LeaveTangentWeight);
            }
            else
            {
                transfer.Move(ref ArriveTangent);
                transfer.Move(ref LeaveTangent);
                transfer.Move(ref ArriveTangentWeight);
                transfer.Move(ref LeaveTangentWeight);
                transfer.Move(ref TangentWeightMode);
            }

            return this;
        }
    }
}
