namespace AssetTool
{
    [JsonAsset("SoundSubmixBase")]
    public class USoundSubmixBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundSubmixWithParentBase")]
    public class USoundSubmixWithParentBase : USoundSubmixBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundSubmix")]
    public class USoundSubmix : USoundSubmixWithParentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundfieldSubmix")]
    public class USoundfieldSubmix : USoundSubmixWithParentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EndpointSubmix")]
    public class UEndpointSubmix : USoundSubmixBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundfieldEndpointSubmix")]
    public class USoundfieldEndpointSubmix : USoundSubmixBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}