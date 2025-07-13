namespace AssetTool
{
    [JsonAsset("ClassWithNetRoleSwapping")]
    public class UClassWithNetRoleSwapping : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}