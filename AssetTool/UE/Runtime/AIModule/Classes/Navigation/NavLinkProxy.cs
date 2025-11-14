namespace AssetTool
{
    [JsonAsset("NavLinkProxy")]
    public class ANavLinkProxy : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}