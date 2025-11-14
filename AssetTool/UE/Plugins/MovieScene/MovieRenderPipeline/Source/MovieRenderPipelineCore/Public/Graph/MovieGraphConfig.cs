namespace AssetTool
{
    [JsonAsset("MovieGraphMember")]
    public class UMovieGraphMember : UMovieGraphValueContainer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphVariable")]
    public class UMovieGraphVariable : UMovieGraphMember
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphGlobalVariable")]
    public class UMovieGraphGlobalVariable : UMovieGraphVariable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphGlobalVariable_ShotName")]
    public class UMovieGraphGlobalVariable_ShotName : UMovieGraphGlobalVariable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphGlobalVariable_SequenceName")]
    public class UMovieGraphGlobalVariable_SequenceName : UMovieGraphGlobalVariable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphGlobalVariable_FrameNumber")]
    public class UMovieGraphGlobalVariable_FrameNumber : UMovieGraphGlobalVariable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphGlobalVariable_CameraName")]
    public class UMovieGraphGlobalVariable_CameraName : UMovieGraphGlobalVariable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphInterfaceBase")]
    public class UMovieGraphInterfaceBase : UMovieGraphMember
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphInput")]
    public class UMovieGraphInput : UMovieGraphInterfaceBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphOutput")]
    public class UMovieGraphOutput : UMovieGraphInterfaceBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphEvaluatedConfig")]
    public class UMovieGraphEvaluatedConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphConfig")]
    public class UMovieGraphConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}