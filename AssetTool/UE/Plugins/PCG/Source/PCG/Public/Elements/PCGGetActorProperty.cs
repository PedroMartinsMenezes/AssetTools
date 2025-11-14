namespace AssetTool
{
    [JsonAsset("PCGGetActorPropertySettings")]
    public class UPCGGetActorPropertySettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}