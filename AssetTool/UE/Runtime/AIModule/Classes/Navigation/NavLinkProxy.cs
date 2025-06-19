namespace AssetTool
{
    [JsonAsset("NavLinkProxy")]
    public class ANavLinkProxy : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}