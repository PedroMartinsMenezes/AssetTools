namespace AssetTool
{
    [JsonAsset("HUD")]
    public class AHUD : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}