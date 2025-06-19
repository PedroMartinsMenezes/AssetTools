namespace AssetTool
{
    [JsonAsset("DamageType")]
    public class UDamageType : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}