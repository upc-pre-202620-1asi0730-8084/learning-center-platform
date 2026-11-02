using Acme.Center.Platform.Publishing.Domain.Model.Aggregates;
using Acme.Center.Platform.Publishing.Domain.Model.ValueObjects;
using Acme.Center.Platform.Shared.Domain.Repositories;

namespace Acme.Center.Platform.Publishing.Domain.Repositories;

/// <summary>
///     Represents the tutorial repository in the ACME Learning Center Platform.
/// </summary>
public interface ITutorialRepository : IBaseRepository<Tutorial>
{
    /// <summary>
    ///     Finds a tutorial by category id asynchronously.
    /// </summary>
    /// <param name="categoryId">
    ///     The id of the category to find tutorials by.
    /// </param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    ///     A collection of tutorials that belong to the category.
    /// </returns>
    Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(CategoryId categoryId, CancellationToken cancellationToken);

    /// <summary>
    ///     Finds a tutorial by category id without change tracking asynchronously.
    /// </summary>
    /// <param name="categoryId">
    ///     The id of the category to find tutorials by.
    /// </param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    ///     A collection of tutorials that belong to the category.
    /// </returns>
    Task<IEnumerable<Tutorial>> FindByCategoryIdAsNoTrackingAsync(CategoryId categoryId, CancellationToken cancellationToken);

    /// <summary>
    ///     Checks whether a tutorial with the given title exists.
    /// </summary>
    Task<bool> ExistsByTitleAsync(string title, CancellationToken cancellationToken);
}