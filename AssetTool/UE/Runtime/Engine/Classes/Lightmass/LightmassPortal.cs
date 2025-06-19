namespace AssetTool
{
    [JsonAsset("LightmassPortal")]
    public class ALightmassPortal : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}