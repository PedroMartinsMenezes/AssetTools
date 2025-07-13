namespace AssetTool
{
    [JsonAsset("NNERuntimeIREECpu")]
    public class UNNERuntimeIREECpu : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NNERuntimeIREEGpu")]
    public class UNNERuntimeIREEGpu : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NNERuntimeIREECuda")]
    public class UNNERuntimeIREECuda : UNNERuntimeIREEGpu
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NNERuntimeIREEVulkan")]
    public class UNNERuntimeIREEVulkan : UNNERuntimeIREEGpu
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NNERuntimeIREERdg")]
    public class UNNERuntimeIREERdg : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}