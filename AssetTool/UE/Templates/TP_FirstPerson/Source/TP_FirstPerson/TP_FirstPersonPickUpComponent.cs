namespace AssetTool
{
    [JsonAsset("TP_FirstPersonPickUpComponent")]
    public class UTP_FirstPersonPickUpComponent : USphereComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}