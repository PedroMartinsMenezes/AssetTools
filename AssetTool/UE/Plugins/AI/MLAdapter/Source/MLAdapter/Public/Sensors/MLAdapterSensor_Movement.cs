namespace AssetTool
{
    [JsonAsset("MLAdapterSensor_Movement")]
    public class UMLAdapterSensor_Movement : UMLAdapterSensor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}