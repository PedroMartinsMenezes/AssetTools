namespace AssetTool
{
    [JsonAsset("ARTrackedGeometry")]
    public class UARTrackedGeometry : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARPlaneGeometry")]
    public class UARPlaneGeometry : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTrackedPoint")]
    public class UARTrackedPoint : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTrackedImage")]
    public class UARTrackedImage : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTrackedQRCode")]
    public class UARTrackedQRCode : UARTrackedImage
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARFaceGeometry")]
    public class UARFaceGeometry : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AREnvironmentCaptureProbe")]
    public class UAREnvironmentCaptureProbe : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTrackedObject")]
    public class UARTrackedObject : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARTrackedPose")]
    public class UARTrackedPose : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARMeshGeometry")]
    public class UARMeshGeometry : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARGeoAnchor")]
    public class UARGeoAnchor : UARTrackedGeometry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}