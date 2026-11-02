using Acme.Center.Platform.Publishing.Domain.Model.Entities;
using Acme.Center.Platform.Publishing.Domain.Model.ValueObjects;
using Acme.Center.Platform.Publishing.Domain.Repositories;
using Acme.Center.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;
using Acme.Center.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Acme.Center.Platform.Publishing.Infrastructure.Persistence.EntityFrameworkCore.Repositories;

/// <summary>
///     Represents the category repository in the ACME Learning Center Platform.
/// </summary>
/// <param name="context">
///     The <see cref="AppDbContext" /> to use.
/// </param>
public class CategoryRepository(AppDbContext context) : BaseRepository<Category>(context), ICategoryRepository
{
    public async Task<Category?> FindByIdAsNoTrackingAsync(
        CategoryId id,
        CancellationToken cancellationToken = default)
    {
        return await Context.Set<Category>()
            .AsNoTracking()
            .FirstOrDefaultAsync(category => category.Id == id, cancellationToken);
    }
}