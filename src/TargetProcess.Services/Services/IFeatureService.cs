﻿using TargetProcess.Base;
using TargetProcess.Data.Dto;

namespace TargetProcess
{
    public interface IFeatureService : IRestApiService, ICrudService<Feature>,
                                       ITargetProcessRequirmentsValidation<Feature> {}

    /// <summary>
    ///     Class FeatureService.
    /// </summary>
    /// <seealso cref="services.Base.CrudService{TargetProcess.Data.Models.Feature}" />
    /// <seealso cref="services.IFeatureService" />
    public class FeatureService : CrudService<Feature>, IFeatureService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FeatureService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public FeatureService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Features";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Feature dto)
            => dto.Name != null && dto.Project != null;
    }
}