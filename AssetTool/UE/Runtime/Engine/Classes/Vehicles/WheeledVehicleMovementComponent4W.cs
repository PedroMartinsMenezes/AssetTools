namespace AssetTool
{
    [JsonAsset("WheeledVehicleMovementComponent4W")]
    public class UWheeledVehicleMovementComponent4W : UObject
    {
        public UWheeledVehicleMovementComponent4W()
        {
            ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
