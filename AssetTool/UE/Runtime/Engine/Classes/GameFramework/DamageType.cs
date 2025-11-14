namespace AssetTool
{
    [JsonAsset("DamageType")]
    public class UDamageType : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}