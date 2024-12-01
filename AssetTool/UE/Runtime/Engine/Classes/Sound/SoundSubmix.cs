namespace AssetTool
{
    [JsonAsset("SoundSubmixBase")]
    public class USoundSubmixBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundSubmixWithParentBase")]
    public class USoundSubmixWithParentBase : USoundSubmixBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundSubmix")]
    public class USoundSubmix : USoundSubmixWithParentBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundfieldSubmix")]
    public class USoundfieldSubmix : USoundSubmixWithParentBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EndpointSubmix")]
    public class UEndpointSubmix : USoundSubmixBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundfieldEndpointSubmix")]
    public class USoundfieldEndpointSubmix : USoundSubmixBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}