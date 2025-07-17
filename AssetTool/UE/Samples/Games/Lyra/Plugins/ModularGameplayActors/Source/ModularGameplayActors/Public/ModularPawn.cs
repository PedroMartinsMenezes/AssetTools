namespace AssetTool
{
    [JsonAsset("ModularPawn")]
    public class AModularPawn : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}