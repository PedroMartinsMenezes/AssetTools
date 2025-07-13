namespace AssetTool
{
    [JsonAsset("MassStateTreeSchema")]
    public class UMassStateTreeSchema : UStateTreeSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}