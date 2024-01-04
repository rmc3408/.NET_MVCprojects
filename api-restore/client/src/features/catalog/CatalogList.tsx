import { Product } from '../../types/Product'


interface CatalogListProps {
  products: Product[]
}
function CatalogList({ products}: CatalogListProps) {
  return (
    <ul>
      {products.map(product => (
        <li key={product.id}>{product.name}</li>
      ))}
    </ul>
  )
}

export default CatalogList