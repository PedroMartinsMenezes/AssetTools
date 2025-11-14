namespace AssetTool
{
    [JsonAsset("ARTypesDummyClass")]
    public class UARTypesDummyClass : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARCandidateImage")]
    public class UARCandidateImage : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARCandidateObject")]
    public class UARCandidateObject : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}