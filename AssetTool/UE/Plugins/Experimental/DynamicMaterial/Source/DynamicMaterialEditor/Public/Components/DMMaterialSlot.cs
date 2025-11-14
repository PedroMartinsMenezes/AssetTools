namespace AssetTool
{
    [JsonAsset("DMMaterialSlot")]
    public class UDMMaterialSlot : UDMMaterialComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}