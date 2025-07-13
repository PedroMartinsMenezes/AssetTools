namespace AssetTool
{
    [JsonAsset("ARTypesDummyClass")]
    public class UARTypesDummyClass : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARCandidateImage")]
    public class UARCandidateImage : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARCandidateObject")]
    public class UARCandidateObject : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}