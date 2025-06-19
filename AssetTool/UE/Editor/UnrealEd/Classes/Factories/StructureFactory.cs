namespace AssetTool
{
    [JsonAsset("StructureFactory")]
    public class UStructureFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}