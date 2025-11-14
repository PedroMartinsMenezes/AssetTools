namespace AssetTool
{
    [JsonAsset("CurveFactory")]
    public class UCurveFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CurveFloatFactory")]
    public class UCurveFloatFactory : UCurveFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CurveLinearColorFactory")]
    public class UCurveLinearColorFactory : UCurveFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CurveVectorFactory")]
    public class UCurveVectorFactory : UCurveFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}