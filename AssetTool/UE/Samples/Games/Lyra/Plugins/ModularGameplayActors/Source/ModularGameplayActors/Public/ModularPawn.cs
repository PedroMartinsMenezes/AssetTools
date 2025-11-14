namespace AssetTool
{
    [JsonAsset("ModularPawn")]
    public class AModularPawn : APawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}