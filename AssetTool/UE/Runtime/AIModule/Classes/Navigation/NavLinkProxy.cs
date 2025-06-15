namespace AssetTool
{
    [JsonAsset("NavLinkProxy")]
    public class ANavLinkProxy : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}