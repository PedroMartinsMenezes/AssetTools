namespace AssetTool
{
    [JsonAsset("UserToolBoxBaseBlueprint")]
    public class UUserToolBoxBaseBlueprint : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}