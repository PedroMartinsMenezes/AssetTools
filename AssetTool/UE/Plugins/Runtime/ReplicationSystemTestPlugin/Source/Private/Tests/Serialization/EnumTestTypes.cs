namespace AssetTool
{
    [JsonAsset("ClassWithNetRoleSwapping")]
    public class UClassWithNetRoleSwapping : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}